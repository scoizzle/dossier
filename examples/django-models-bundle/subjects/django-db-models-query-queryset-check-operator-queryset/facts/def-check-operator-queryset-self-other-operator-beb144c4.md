# Fact beb144c4

Store id: 8f0bd9c2-0fd8-4993-91f2-db87dd7f7a80

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
- posted_at: `2026-11-09T23:44:56.1880700+00:00`

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
  "id": "8f0bd9c2-0fd8-4993-91f2-db87dd7f7a80",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1880700+00:00"
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
  "subject_id": "521531f7-4ca3-4b97-b570-6fd58ee292c3",
  "subject_name": "django/db/models/query::QuerySet._check_operator_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_operator_queryset(self, other, operator_)"
}
```
