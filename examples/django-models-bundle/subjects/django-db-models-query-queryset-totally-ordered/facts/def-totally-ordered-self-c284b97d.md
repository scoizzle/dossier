# Fact c284b97d

Store id: c39f93d6-7940-44a0-b588-be259fa77538

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
- posted_at: `2026-11-09T22:39:49.6872860+00:00`

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
  "id": "c39f93d6-7940-44a0-b588-be259fa77538",
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
    "posted_at": "2026-11-09T22:39:49.6872860+00:00"
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
  "subject_id": "3538f2aa-dc5f-4bfb-adfa-2ee20e45b673",
  "subject_name": "django/db/models/query::QuerySet.totally_ordered",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def totally_ordered(self)"
}
```
