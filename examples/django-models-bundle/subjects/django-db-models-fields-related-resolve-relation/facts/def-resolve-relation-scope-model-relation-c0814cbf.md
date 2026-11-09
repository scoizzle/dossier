# Fact c0814cbf

Store id: 2b09176b-d8c0-4e00-9438-699b9952bc3d

## Text

```text
def resolve_relation(scope_model, relation)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.2179020+00:00`

## Data

```json
{
  "end_line": 74,
  "entity_kind": "function",
  "parent": "related",
  "start_line": 52,
  "symbol": "resolve_relation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"selector":"L52-L74","symbol":"resolve_relation"}`

## Items

```json
[
  {
    "text": "Transform relation into a model or fully-qualified model string of the form \"app_label.ModelName\", relative to scope_model.",
    "locator": {
      "line": 53
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::resolve_relation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 74,
    "entity_kind": "function",
    "parent": "related",
    "start_line": 52,
    "symbol": "resolve_relation"
  },
  "id": "2b09176b-d8c0-4e00-9438-699b9952bc3d",
  "items": [
    {
      "locator": {
        "line": 53
      },
      "text": "Transform relation into a model or fully-qualified model string of the form \"app_label.ModelName\", relative to scope_model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2179020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 52,
        "selector": "L52-L74",
        "symbol": "resolve_relation"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "66640c92-895c-4626-b47e-9eefc6b3d6ca",
  "subject_name": "django/db/models/fields/related::resolve_relation",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_relation(scope_model, relation)"
}
```
