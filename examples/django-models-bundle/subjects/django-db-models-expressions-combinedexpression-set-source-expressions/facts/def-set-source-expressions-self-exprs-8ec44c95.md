# Fact 8ec44c95

Store id: 24b49883-8351-4731-83b6-09173bed93fe

## Text

```text
def set_source_expressions(self, exprs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8150320+00:00`

## Data

```json
{
  "end_line": 745,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 744,
  "symbol": "CombinedExpression.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":744,"selector":"L744-L745","symbol":"CombinedExpression.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 745,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 744,
    "symbol": "CombinedExpression.set_source_expressions"
  },
  "id": "24b49883-8351-4731-83b6-09173bed93fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8150320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 744,
        "selector": "L744-L745",
        "symbol": "CombinedExpression.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "10b5e694-50e2-4af6-a022-9f0b2f552978",
  "subject_name": "django/db/models/expressions::CombinedExpression.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
