# Fact afbc1dbd

Store id: 712dfb37-89b0-4feb-91a1-cdb51c3b47a3

## Text

```text
class FetchRaise(FetchMode)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.2270820+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 49,
  "symbol": "FetchRaise"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L58","symbol":"FetchRaise"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchRaise](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 49,
    "symbol": "FetchRaise"
  },
  "id": "712dfb37-89b0-4feb-91a1-cdb51c3b47a3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2270820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L58",
        "symbol": "FetchRaise"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "f715fece-43b8-414f-8295-94e6b3379c7f",
  "subject_name": "django/db/models/fetch_modes::FetchRaise",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchRaise(FetchMode)"
}
```
