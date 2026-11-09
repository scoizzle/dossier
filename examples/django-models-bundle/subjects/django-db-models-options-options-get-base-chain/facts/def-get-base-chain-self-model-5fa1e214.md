# Fact 5fa1e214

Store id: 0b88fd26-f0ba-4edd-9937-c3fed31e39fc

## Text

```text
def get_base_chain(self, model)
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
- posted_at: `2026-11-09T22:39:48.8708210+00:00`

## Data

```json
{
  "end_line": 712,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 697,
  "symbol": "Options.get_base_chain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":697,"selector":"L697-L712","symbol":"Options.get_base_chain"}`

## Items

```json
[
  {
    "text": "Return a list of parent classes leading to `model` (ordered from closest to most distant ancestor). This has to handle the case where `model` is a grandparent or even more distant relation.",
    "locator": {
      "line": 698
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_base_chain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 712,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 697,
    "symbol": "Options.get_base_chain"
  },
  "id": "0b88fd26-f0ba-4edd-9937-c3fed31e39fc",
  "items": [
    {
      "locator": {
        "line": 698
      },
      "text": "Return a list of parent classes leading to `model` (ordered from closest to most distant ancestor). This has to handle the case where `model` is a grandparent or even more distant relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8708210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 697,
        "selector": "L697-L712",
        "symbol": "Options.get_base_chain"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "985d927c-11ac-4691-b395-60f82d10e87a",
  "subject_name": "django/db/models/options::Options.get_base_chain",
  "tags": [
    "entity:method"
  ],
  "text": "def get_base_chain(self, model)"
}
```
