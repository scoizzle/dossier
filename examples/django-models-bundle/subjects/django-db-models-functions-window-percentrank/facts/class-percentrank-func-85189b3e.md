# Fact 85189b3e

Store id: 06988659-d4ae-4c4f-bfc7-b1a2095afa7e

## Text

```text
class PercentRank(Func)
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
- posted_at: `2026-11-09T23:44:54.5045210+00:00`

## Data

```json
{
  "end_line": 108,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 105,
  "symbol": "PercentRank"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":105,"selector":"L105-L108","symbol":"PercentRank"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::PercentRank](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 108,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 105,
    "symbol": "PercentRank"
  },
  "id": "06988659-d4ae-4c4f-bfc7-b1a2095afa7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.5045210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 105,
        "selector": "L105-L108",
        "symbol": "PercentRank"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "c7ad23ec-3dcd-4702-a7e5-fc8255653451",
  "subject_name": "django/db/models/functions/window::PercentRank",
  "tags": [
    "entity:class"
  ],
  "text": "class PercentRank(Func)"
}
```
