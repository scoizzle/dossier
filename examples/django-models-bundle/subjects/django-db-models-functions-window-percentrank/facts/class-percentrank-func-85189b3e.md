# Fact 85189b3e

Store id: 1fe01890-7bdb-4f3e-97a1-3985fe7aa2bc

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
- posted_at: `2026-11-09T22:39:47.6009350+00:00`

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
  "id": "1fe01890-7bdb-4f3e-97a1-3985fe7aa2bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.6009350+00:00"
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
  "subject_id": "e36f0f8f-0f0c-4192-b5f3-1d0ca0c4bcc1",
  "subject_name": "django/db/models/functions/window::PercentRank",
  "tags": [
    "entity:class"
  ],
  "text": "class PercentRank(Func)"
}
```
