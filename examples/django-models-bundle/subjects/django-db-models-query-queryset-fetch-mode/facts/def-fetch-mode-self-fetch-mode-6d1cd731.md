# Fact 6d1cd731

Store id: 5f6156aa-5168-4b1f-bf2b-0a628709ec73

## Text

```text
def fetch_mode(self, fetch_mode)
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
- posted_at: `2026-11-09T23:44:56.1148010+00:00`

## Data

```json
{
  "end_line": 2029,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2025,
  "symbol": "QuerySet.fetch_mode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2025,"selector":"L2025-L2029","symbol":"QuerySet.fetch_mode"}`

## Items

```json
[
  {
    "text": "Set the fetch mode for the QuerySet.",
    "locator": {
      "line": 2026
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.fetch_mode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2029,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2025,
    "symbol": "QuerySet.fetch_mode"
  },
  "id": "5f6156aa-5168-4b1f-bf2b-0a628709ec73",
  "items": [
    {
      "locator": {
        "line": 2026
      },
      "text": "Set the fetch mode for the QuerySet."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1148010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2025,
        "selector": "L2025-L2029",
        "symbol": "QuerySet.fetch_mode"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2b845cac-f893-4267-be9f-f0dc9a2d5237",
  "subject_name": "django/db/models/query::QuerySet.fetch_mode",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_mode(self, fetch_mode)"
}
```
