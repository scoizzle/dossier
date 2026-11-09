# Fact b72f38b2

Store id: 4d960714-5abd-4dac-bbcc-56414b0a8919

## Text

```text
def get_count(self, using)
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
- posted_at: `2026-11-09T22:39:51.2589810+00:00`

## Data

```json
{
  "end_line": 656,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 651,
  "symbol": "Query.get_count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":651,"selector":"L651-L656","symbol":"Query.get_count"}`

## Items

```json
[
  {
    "text": "Perform a COUNT() query using the current filter constraints.",
    "locator": {
      "line": 652
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 656,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 651,
    "symbol": "Query.get_count"
  },
  "id": "4d960714-5abd-4dac-bbcc-56414b0a8919",
  "items": [
    {
      "locator": {
        "line": 652
      },
      "text": "Perform a COUNT() query using the current filter constraints."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2589810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 651,
        "selector": "L651-L656",
        "symbol": "Query.get_count"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "73d3673c-2756-4ced-9186-987b1b1de8ee",
  "subject_name": "django/db/models/sql/query::Query.get_count",
  "tags": [
    "entity:method"
  ],
  "text": "def get_count(self, using)"
}
```
