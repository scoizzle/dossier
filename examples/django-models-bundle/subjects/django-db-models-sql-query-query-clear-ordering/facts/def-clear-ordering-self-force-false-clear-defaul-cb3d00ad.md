# Fact cb3d00ad

Store id: 15d0f42d-7526-4f0d-a8cd-9fb3c15924e5

## Text

```text
def clear_ordering(self, force=False, clear_default=True)
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
- posted_at: `2026-11-09T23:44:58.9905220+00:00`

## Data

```json
{
  "end_line": 2409,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2390,
  "symbol": "Query.clear_ordering"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2390,"selector":"L2390-L2409","symbol":"Query.clear_ordering"}`

## Items

```json
[
  {
    "text": "Remove any ordering settings if the current query allows it without side effects, set 'force' to True to clear the ordering regardless. If 'clear_default' is True, there will be no ordering in the resulting query (not even the model's default).",
    "locator": {
      "line": 2391
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_ordering](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2409,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2390,
    "symbol": "Query.clear_ordering"
  },
  "id": "15d0f42d-7526-4f0d-a8cd-9fb3c15924e5",
  "items": [
    {
      "locator": {
        "line": 2391
      },
      "text": "Remove any ordering settings if the current query allows it without side effects, set 'force' to True to clear the ordering regardless. If 'clear_default' is True, there will be no ordering in the resulting query (not even the model's default)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9905220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2390,
        "selector": "L2390-L2409",
        "symbol": "Query.clear_ordering"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6978ea6e-94aa-4fe7-be54-1fc691c92c83",
  "subject_name": "django/db/models/sql/query::Query.clear_ordering",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_ordering(self, force=False, clear_default=True)"
}
```
