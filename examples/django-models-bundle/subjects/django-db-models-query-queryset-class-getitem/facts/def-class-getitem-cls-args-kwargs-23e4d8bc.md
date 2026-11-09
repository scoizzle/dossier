# Fact 23e4d8bc

Store id: e7972887-1567-4dad-932d-1356e229ec67

## Text

```text
def __class_getitem__(cls, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.8657170+00:00`

## Data

```json
{
  "end_line": 528,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 527,
  "symbol": "QuerySet.__class_getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":527,"selector":"L527-L528","symbol":"QuerySet.__class_getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__class_getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 528,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 527,
    "symbol": "QuerySet.__class_getitem__"
  },
  "id": "e7972887-1567-4dad-932d-1356e229ec67",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8657170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 527,
        "selector": "L527-L528",
        "symbol": "QuerySet.__class_getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7e567a26-8356-4a95-8dcb-3ac9c0ae246a",
  "subject_name": "django/db/models/query::QuerySet.__class_getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __class_getitem__(cls, *args, **kwargs)"
}
```
