# Fact afbc1dbd

Store id: 3fb6cad7-9401-4482-8a1f-a60effc9b9d4

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
- posted_at: `2026-11-09T22:39:42.0085120+00:00`

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
  "id": "3fb6cad7-9401-4482-8a1f-a60effc9b9d4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.0085120+00:00"
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
  "subject_id": "68408bf3-30fe-4629-b342-95a16ad2f3c1",
  "subject_name": "django/db/models/fetch_modes::FetchRaise",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchRaise(FetchMode)"
}
```
