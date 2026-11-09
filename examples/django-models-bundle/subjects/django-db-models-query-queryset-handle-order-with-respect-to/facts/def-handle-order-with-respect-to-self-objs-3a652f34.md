# Fact 3a652f34

Store id: 2fd0cdab-b99d-4132-8e61-ab674525b2b4

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
- posted_at: `2026-11-09T22:39:49.4191750+00:00`

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
  "id": "2fd0cdab-b99d-4132-8e61-ab674525b2b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4191750+00:00"
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
  "subject_id": "4c59c1c5-1b18-4810-826e-dba57164596a",
  "subject_name": "django/db/models/query::QuerySet._handle_order_with_respect_to",
  "tags": [
    "entity:method"
  ],
  "text": "def _handle_order_with_respect_to(self, objs)"
}
```
