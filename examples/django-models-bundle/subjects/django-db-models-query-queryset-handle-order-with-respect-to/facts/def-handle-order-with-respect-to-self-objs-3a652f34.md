# Fact 3a652f34

Store id: 89c662f3-b79a-4f7c-9fd2-ebf051c684c4

## Text

```text
def _handle_order_with_respect_to(self, objs)
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
- posted_at: `2026-11-09T23:44:55.9149750+00:00`

## Data

```json
{
  "end_line": 967,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 938,
  "symbol": "QuerySet._handle_order_with_respect_to"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":938,"selector":"L938-L967","symbol":"QuerySet._handle_order_with_respect_to"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._handle_order_with_respect_to](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 967,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 938,
    "symbol": "QuerySet._handle_order_with_respect_to"
  },
  "id": "89c662f3-b79a-4f7c-9fd2-ebf051c684c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9149750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 938,
        "selector": "L938-L967",
        "symbol": "QuerySet._handle_order_with_respect_to"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "633141da-e326-46d9-9277-cb5e097f64f4",
  "subject_name": "django/db/models/query::QuerySet._handle_order_with_respect_to",
  "tags": [
    "entity:method"
  ],
  "text": "def _handle_order_with_respect_to(self, objs)"
}
```
