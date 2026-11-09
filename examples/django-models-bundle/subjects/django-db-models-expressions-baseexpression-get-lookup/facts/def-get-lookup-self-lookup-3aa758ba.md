# Fact 3aa758ba

Store id: 43fba60b-7bcd-4c19-8fa1-8d6ed03b39e8

## Text

```text
def get_lookup(self, lookup)
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
- posted_at: `2026-11-09T23:31:55.7848510+00:00`

## Data

```json
{
  "end_line": 404,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 403,
  "symbol": "BaseExpression.get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":403,"selector":"L403-L404","symbol":"BaseExpression.get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 404,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 403,
    "symbol": "BaseExpression.get_lookup"
  },
  "id": "43fba60b-7bcd-4c19-8fa1-8d6ed03b39e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7848510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 403,
        "selector": "L403-L404",
        "symbol": "BaseExpression.get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c543fc33-2e7c-43a4-9273-3aacdabf3b3c",
  "subject_name": "django/db/models/expressions::BaseExpression.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup)"
}
```
