# Fact bfccb6c9

Store id: bd078b5e-a384-462e-ab78-785d7a4c83da

## Text

```text
class IContains(Contains)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.0240390+00:00`

## Data

```json
{
  "end_line": 632,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 630,
  "symbol": "IContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":630,"selector":"L630-L632","symbol":"IContains"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 632,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 630,
    "symbol": "IContains"
  },
  "id": "bd078b5e-a384-462e-ab78-785d7a4c83da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0240390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 630,
        "selector": "L630-L632",
        "symbol": "IContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "9a6e7d58-7b38-455f-b774-5fc37f634c4c",
  "subject_name": "django/db/models/lookups::IContains",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IContains(Contains)"
}
```
