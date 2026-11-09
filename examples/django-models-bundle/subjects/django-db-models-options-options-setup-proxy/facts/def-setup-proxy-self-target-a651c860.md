# Fact a651c860

Store id: 4f97fca7-68a9-43cd-9d82-ae551d37d59f

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
- posted_at: `2026-11-09T23:32:03.9351410+00:00`

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
  "id": "4f97fca7-68a9-43cd-9d82-ae551d37d59f",
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
    "posted_at": "2026-11-09T23:32:03.9351410+00:00"
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
  "subject_id": "c4dce91e-f228-4422-94c9-57f157793506",
  "subject_name": "django/db/models/options::Options.setup_proxy",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_proxy(self, target)"
}
```
