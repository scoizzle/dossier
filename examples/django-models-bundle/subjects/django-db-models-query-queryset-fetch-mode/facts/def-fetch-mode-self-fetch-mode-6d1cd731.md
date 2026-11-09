# Fact 6d1cd731

Store id: 32709224-b8f7-4876-8991-de06d79faa39

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
- posted_at: `2026-11-09T23:32:04.6046630+00:00`

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
  "id": "32709224-b8f7-4876-8991-de06d79faa39",
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
    "posted_at": "2026-11-09T23:32:04.6046630+00:00"
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
  "subject_id": "a177c657-47aa-49fb-8ef2-178f1676c86a",
  "subject_name": "django/db/models/query::QuerySet.fetch_mode",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_mode(self, fetch_mode)"
}
```
