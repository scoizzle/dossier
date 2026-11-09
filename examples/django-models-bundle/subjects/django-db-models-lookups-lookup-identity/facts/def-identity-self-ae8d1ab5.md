# Fact ae8d1ab5

Store id: 07a8db6a-2dd9-4444-bd1b-960d5be81d42

## Text

```text
def identity(self)
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
- posted_at: `2026-11-09T23:44:54.8964920+00:00`

## Data

```json
{
  "end_line": 174,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 172,
  "symbol": "Lookup.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L174","symbol":"Lookup.identity"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 174,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 172,
    "symbol": "Lookup.identity"
  },
  "id": "07a8db6a-2dd9-4444-bd1b-960d5be81d42",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8964920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L174",
        "symbol": "Lookup.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4a7efbc5-e788-4801-a328-b00d6300db09",
  "subject_name": "django/db/models/lookups::Lookup.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
