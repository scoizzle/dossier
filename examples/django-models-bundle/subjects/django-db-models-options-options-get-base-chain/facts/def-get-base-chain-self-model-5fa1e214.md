# Fact 5fa1e214

Store id: 10e34a5d-fbd9-466a-a728-a9436eaba5f7

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
- posted_at: `2026-11-09T23:32:04.0037220+00:00`

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
  "id": "10e34a5d-fbd9-466a-a728-a9436eaba5f7",
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
    "posted_at": "2026-11-09T23:32:04.0037220+00:00"
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
  "subject_id": "6baa6dc9-9e45-4bdc-8cc7-3212cfc7f4e0",
  "subject_name": "django/db/models/options::Options.get_base_chain",
  "tags": [
    "entity:method"
  ],
  "text": "def get_base_chain(self, model)"
}
```
