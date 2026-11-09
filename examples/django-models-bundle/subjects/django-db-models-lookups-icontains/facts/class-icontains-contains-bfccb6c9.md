# Fact bfccb6c9

Store id: 02cc0506-af7a-4a36-b881-b095f87a3769

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
- posted_at: `2026-11-09T22:39:48.1812720+00:00`

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
  "id": "02cc0506-af7a-4a36-b881-b095f87a3769",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1812720+00:00"
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
  "subject_id": "21a7d083-462c-4c20-901f-88203a3dab18",
  "subject_name": "django/db/models/lookups::IContains",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IContains(Contains)"
}
```
