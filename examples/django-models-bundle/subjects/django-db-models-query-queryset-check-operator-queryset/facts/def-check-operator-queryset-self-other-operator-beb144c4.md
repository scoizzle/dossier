# Fact beb144c4

Store id: 413684fd-714f-4a0b-8196-e3821eb38816

## Text

```text
def _check_operator_queryset(self, other, operator_)
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
- posted_at: `2026-11-09T22:39:49.7452250+00:00`

## Data

```json
{
  "end_line": 2369,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2367,
  "symbol": "QuerySet._check_operator_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2367,"selector":"L2367-L2369","symbol":"QuerySet._check_operator_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._check_operator_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2369,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2367,
    "symbol": "QuerySet._check_operator_queryset"
  },
  "id": "413684fd-714f-4a0b-8196-e3821eb38816",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7452250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2367,
        "selector": "L2367-L2369",
        "symbol": "QuerySet._check_operator_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4cb49a2c-0cf2-4816-9b46-545449a6ebb6",
  "subject_name": "django/db/models/query::QuerySet._check_operator_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_operator_queryset(self, other, operator_)"
}
```
