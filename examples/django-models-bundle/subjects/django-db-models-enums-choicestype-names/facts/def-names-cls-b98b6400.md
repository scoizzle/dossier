# Fact b98b6400

Store id: fa997758-e059-4d93-a71a-3a8ddc989e4b

## Text

```text
def names(cls)
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
- posted_at: `2026-11-09T23:44:49.0426930+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 35,
  "symbol": "ChoicesType.names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L38","symbol":"ChoicesType.names"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 35,
    "symbol": "ChoicesType.names"
  },
  "id": "fa997758-e059-4d93-a71a-3a8ddc989e4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0426930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L38",
        "symbol": "ChoicesType.names"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "0792fb13-4a59-4dc2-bd3d-17d5b865bf03",
  "subject_name": "django/db/models/enums::ChoicesType.names",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def names(cls)"
}
```
