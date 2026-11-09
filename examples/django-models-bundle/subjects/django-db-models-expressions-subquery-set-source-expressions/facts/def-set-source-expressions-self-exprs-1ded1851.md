# Fact 1ded1851

Store id: bfbb5c42-4661-4269-a9f0-65cc0975772b

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
- posted_at: `2026-11-09T23:31:55.9695990+00:00`

## Data

```json
{
  "end_line": 1839,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1838,
  "symbol": "Subquery.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1838,"selector":"L1838-L1839","symbol":"Subquery.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1839,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1838,
    "symbol": "Subquery.set_source_expressions"
  },
  "id": "bfbb5c42-4661-4269-a9f0-65cc0975772b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9695990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1838,
        "selector": "L1838-L1839",
        "symbol": "Subquery.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "91cbb7e9-cf5d-4fab-b50a-c0254e371366",
  "subject_name": "django/db/models/expressions::Subquery.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
