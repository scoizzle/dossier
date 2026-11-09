# Fact c0814cbf

Store id: dc4a493e-715b-4ed3-b09b-5842493c2e3b

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
- posted_at: `2026-11-09T23:44:51.4455120+00:00`

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
  "id": "dc4a493e-715b-4ed3-b09b-5842493c2e3b",
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
    "posted_at": "2026-11-09T23:44:51.4455120+00:00"
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
  "subject_id": "ddc8c5c8-6314-40a9-8201-a286fa8bd9bb",
  "subject_name": "django/db/models/fields/related::resolve_relation",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_relation(scope_model, relation)"
}
```
