# Fact d6db0170

Store id: 9cba31fc-936c-40e3-a99e-d56de4d34a98

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:32:04.7418120+00:00`

## Data

```json
{
  "end_line": 2501,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2499,
  "symbol": "RawQuerySet.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2499,"selector":"L2499-L2501","symbol":"RawQuerySet.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2501,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2499,
    "symbol": "RawQuerySet.__iter__"
  },
  "id": "9cba31fc-936c-40e3-a99e-d56de4d34a98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7418120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2499,
        "selector": "L2499-L2501",
        "symbol": "RawQuerySet.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "11863f07-25b5-49d8-8882-0320291b7a83",
  "subject_name": "django/db/models/query::RawQuerySet.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
