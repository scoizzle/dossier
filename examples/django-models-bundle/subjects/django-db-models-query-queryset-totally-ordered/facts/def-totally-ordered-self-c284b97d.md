# Fact c284b97d

Store id: 1e8af163-2f98-4b20-8e84-aa17f0c3857f

## Text

```text
def totally_ordered(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.1233440+00:00`

## Data

```json
{
  "end_line": 2128,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2056,
  "symbol": "QuerySet.totally_ordered"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2056,"selector":"L2056-L2128","symbol":"QuerySet.totally_ordered"}`

## Items

```json
[
  {
    "text": "Returns True if the QuerySet is ordered and the ordering is deterministic. This requires that the ordering includes a field (or set of fields) that is unique and non-nullable.",
    "locator": {
      "line": 2058
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.totally_ordered](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2128,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2056,
    "symbol": "QuerySet.totally_ordered"
  },
  "id": "1e8af163-2f98-4b20-8e84-aa17f0c3857f",
  "items": [
    {
      "locator": {
        "line": 2058
      },
      "text": "Returns True if the QuerySet is ordered and the ordering is deterministic. This requires that the ordering includes a field (or set of fields) that is unique and non-nullable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1233440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2056,
        "selector": "L2056-L2128",
        "symbol": "QuerySet.totally_ordered"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fc897583-0cec-4742-83c6-dfd9dbc85537",
  "subject_name": "django/db/models/query::QuerySet.totally_ordered",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def totally_ordered(self)"
}
```
