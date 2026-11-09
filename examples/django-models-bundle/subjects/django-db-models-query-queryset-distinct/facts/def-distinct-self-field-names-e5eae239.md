# Fact e5eae239

Store id: d91fe016-9dfe-4b15-92b3-bfedfb698459

## Text

```text
def distinct(self, *field_names)
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
- posted_at: `2026-11-09T23:44:56.0891160+00:00`

## Data

```json
{
  "end_line": 1954,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1943,
  "symbol": "QuerySet.distinct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1943,"selector":"L1943-L1954","symbol":"QuerySet.distinct"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance that will select only distinct results.",
    "locator": {
      "line": 1944
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.distinct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1954,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1943,
    "symbol": "QuerySet.distinct"
  },
  "id": "d91fe016-9dfe-4b15-92b3-bfedfb698459",
  "items": [
    {
      "locator": {
        "line": 1944
      },
      "text": "Return a new QuerySet instance that will select only distinct results."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0891160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1943,
        "selector": "L1943-L1954",
        "symbol": "QuerySet.distinct"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2161e60f-3d14-4fa5-b689-e4f48190789e",
  "subject_name": "django/db/models/query::QuerySet.distinct",
  "tags": [
    "entity:method"
  ],
  "text": "def distinct(self, *field_names)"
}
```
