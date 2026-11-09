# Fact bec06289

Store id: 66a996d5-fadc-4bbb-8884-02c1d4b549ef

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
- posted_at: `2026-11-09T22:39:49.5818270+00:00`

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
  "id": "66a996d5-fadc-4bbb-8884-02c1d4b549ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5818270+00:00"
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
  "subject_id": "16d16308-9f8d-4aca-8e2e-c08ee79b0080",
  "subject_name": "django/db/models/query::QuerySet.values_list",
  "tags": [
    "entity:method"
  ],
  "text": "def values_list(self, *fields, flat=False, named=False)"
}
```
