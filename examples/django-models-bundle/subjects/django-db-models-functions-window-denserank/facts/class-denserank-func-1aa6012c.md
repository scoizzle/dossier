# Fact 1aa6012c

Store id: 111359b4-93e3-4894-97ea-104c2699f0f0

## Text

```text
class DenseRank(Func)
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
- posted_at: `2026-11-09T23:44:54.4608850+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 25,
  "symbol": "DenseRank"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":25,"selector":"L25-L28","symbol":"DenseRank"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::DenseRank](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 25,
    "symbol": "DenseRank"
  },
  "id": "111359b4-93e3-4894-97ea-104c2699f0f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4608850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 25,
        "selector": "L25-L28",
        "symbol": "DenseRank"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "5c94211b-c85f-406d-b048-aeef3463360c",
  "subject_name": "django/db/models/functions/window::DenseRank",
  "tags": [
    "entity:class"
  ],
  "text": "class DenseRank(Func)"
}
```
