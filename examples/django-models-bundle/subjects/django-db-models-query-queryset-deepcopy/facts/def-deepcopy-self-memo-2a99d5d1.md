# Fact 2a99d5d1

Store id: db265d14-968f-4df1-a4de-111ea9d86325

## Text

```text
def __deepcopy__(self, memo)
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
- posted_at: `2026-11-09T23:44:55.8374780+00:00`

## Data

```json
{
  "end_line": 422,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 414,
  "symbol": "QuerySet.__deepcopy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":414,"selector":"L414-L422","symbol":"QuerySet.__deepcopy__"}`

## Items

```json
[
  {
    "text": "Don't populate the QuerySet's cache.",
    "locator": {
      "line": 415
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__deepcopy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 422,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 414,
    "symbol": "QuerySet.__deepcopy__"
  },
  "id": "db265d14-968f-4df1-a4de-111ea9d86325",
  "items": [
    {
      "locator": {
        "line": 415
      },
      "text": "Don't populate the QuerySet's cache."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8374780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 414,
        "selector": "L414-L422",
        "symbol": "QuerySet.__deepcopy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e6c5e186-1bfc-49e1-b358-ba3e8cdf2d58",
  "subject_name": "django/db/models/query::QuerySet.__deepcopy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __deepcopy__(self, memo)"
}
```
