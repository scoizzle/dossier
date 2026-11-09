# Fact bec06289

Store id: 01f1a31d-6e3a-432e-8ae7-7766786efefd

## Text

```text
def values_list(self, *fields, flat=False, named=False)
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
- posted_at: `2026-11-09T23:44:56.0185280+00:00`

## Data

```json
{
  "end_line": 1623,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1565,
  "symbol": "QuerySet.values_list"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1565,"selector":"L1565-L1623","symbol":"QuerySet.values_list"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.values_list](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1623,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1565,
    "symbol": "QuerySet.values_list"
  },
  "id": "01f1a31d-6e3a-432e-8ae7-7766786efefd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0185280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1565,
        "selector": "L1565-L1623",
        "symbol": "QuerySet.values_list"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6f1bd50d-1eed-401d-acdd-45b1a29cf805",
  "subject_name": "django/db/models/query::QuerySet.values_list",
  "tags": [
    "entity:method"
  ],
  "text": "def values_list(self, *fields, flat=False, named=False)"
}
```
