# Fact a651c860

Store id: 64e4b9bf-84e9-4d8c-b84b-1ed7b2464be9

## Text

```text
def setup_proxy(self, target)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.7990170+00:00`

## Data

```json
{
  "end_line": 387,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 380,
  "symbol": "Options.setup_proxy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":380,"selector":"L380-L387","symbol":"Options.setup_proxy"}`

## Items

```json
[
  {
    "text": "Do the internal setup so that the current model is a proxy for \"target\".",
    "locator": {
      "line": 381
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.setup_proxy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 387,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 380,
    "symbol": "Options.setup_proxy"
  },
  "id": "64e4b9bf-84e9-4d8c-b84b-1ed7b2464be9",
  "items": [
    {
      "locator": {
        "line": 381
      },
      "text": "Do the internal setup so that the current model is a proxy for \"target\"."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7990170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 380,
        "selector": "L380-L387",
        "symbol": "Options.setup_proxy"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "8848cb72-a784-4d2e-9fd2-84330bb137dd",
  "subject_name": "django/db/models/options::Options.setup_proxy",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_proxy(self, target)"
}
```
