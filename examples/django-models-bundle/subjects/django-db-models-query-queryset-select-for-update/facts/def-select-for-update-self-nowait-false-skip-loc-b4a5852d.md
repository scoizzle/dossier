# Fact b4a5852d

Store id: fd303406-eadf-4468-8aa5-8c7a0c773e63

## Text

```text
def select_for_update(self, nowait=False, skip_locked=False, of=(), no_key=False)
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
- posted_at: `2026-11-09T22:39:49.6384480+00:00`

## Data

```json
{
  "end_line": 1802,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1788,
  "symbol": "QuerySet.select_for_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1788,"selector":"L1788-L1802","symbol":"QuerySet.select_for_update"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance that will select objects with a FOR UPDATE lock.",
    "locator": {
      "line": 1789
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.select_for_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1802,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1788,
    "symbol": "QuerySet.select_for_update"
  },
  "id": "fd303406-eadf-4468-8aa5-8c7a0c773e63",
  "items": [
    {
      "locator": {
        "line": 1789
      },
      "text": "Return a new QuerySet instance that will select objects with a FOR UPDATE lock."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6384480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1788,
        "selector": "L1788-L1802",
        "symbol": "QuerySet.select_for_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3e10e628-d4c2-497f-b63f-132308a17597",
  "subject_name": "django/db/models/query::QuerySet.select_for_update",
  "tags": [
    "entity:method"
  ],
  "text": "def select_for_update(self, nowait=False, skip_locked=False, of=(), no_key=False)"
}
```
