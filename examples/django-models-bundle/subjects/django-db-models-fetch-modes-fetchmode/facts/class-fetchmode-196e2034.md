# Fact 196e2034

Store id: cf4473b1-e79f-4cf1-a9e5-4357947d9a71

## Text

```text
class FetchMode
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
- posted_at: `2026-11-09T23:31:56.2019450+00:00`

## Data

```json
{
  "end_line": 10,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 4,
  "symbol": "FetchMode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":4,"selector":"L4-L10","symbol":"FetchMode"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchMode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 10,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 4,
    "symbol": "FetchMode"
  },
  "id": "cf4473b1-e79f-4cf1-a9e5-4357947d9a71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2019450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 4,
        "selector": "L4-L10",
        "symbol": "FetchMode"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "06c6222b-d4e0-4173-9c5e-8fd5495de624",
  "subject_name": "django/db/models/fetch_modes::FetchMode",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchMode"
}
```
