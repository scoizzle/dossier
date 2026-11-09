# Fact 18ebec20

Store id: 12668043-cf43-4ae2-81b6-b3f312a7f646

## Text

```text
def aggregate(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.3689950+00:00`

## Data

```json
{
  "end_line": 677,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 654,
  "symbol": "QuerySet.aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":654,"selector":"L654-L677","symbol":"QuerySet.aggregate"}`

## Items

```json
[
  {
    "text": "Return a dictionary containing the calculations (aggregation) over the current queryset.",
    "locator": {
      "line": 655
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 677,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 654,
    "symbol": "QuerySet.aggregate"
  },
  "id": "12668043-cf43-4ae2-81b6-b3f312a7f646",
  "items": [
    {
      "locator": {
        "line": 655
      },
      "text": "Return a dictionary containing the calculations (aggregation) over the current queryset."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3689950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 654,
        "selector": "L654-L677",
        "symbol": "QuerySet.aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "9614e782-bcfd-408b-8c95-aec30d04a907",
  "subject_name": "django/db/models/query::QuerySet.aggregate",
  "tags": [
    "entity:method"
  ],
  "text": "def aggregate(self, *args, **kwargs)"
}
```
