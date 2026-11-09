# Fact 1aa6012c

Store id: 9035eb4e-3ca8-4bb0-bc17-01b6274618d8

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
- posted_at: `2026-11-09T23:32:02.6807660+00:00`

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
  "id": "9035eb4e-3ca8-4bb0-bc17-01b6274618d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.6807660+00:00"
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
  "subject_id": "c996847d-f8c2-4a7f-8104-5360b8ca13c7",
  "subject_name": "django/db/models/functions/window::DenseRank",
  "tags": [
    "entity:class"
  ],
  "text": "class DenseRank(Func)"
}
```
