# Fact 0ac85ad6

Store id: daa53db4-9100-4ed6-a63f-7d9470fe3b6f

## Text

```text
def explain(self, using, format=None, **options)
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
- posted_at: `2026-11-09T22:39:51.2720090+00:00`

## Data

```json
{
  "end_line": 698,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 688,
  "symbol": "Query.explain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":688,"selector":"L688-L698","symbol":"Query.explain"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.explain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 698,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 688,
    "symbol": "Query.explain"
  },
  "id": "daa53db4-9100-4ed6-a63f-7d9470fe3b6f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2720090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 688,
        "selector": "L688-L698",
        "symbol": "Query.explain"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f259eb98-2f81-4ec6-9848-5862eac6f61f",
  "subject_name": "django/db/models/sql/query::Query.explain",
  "tags": [
    "entity:method"
  ],
  "text": "def explain(self, using, format=None, **options)"
}
```
