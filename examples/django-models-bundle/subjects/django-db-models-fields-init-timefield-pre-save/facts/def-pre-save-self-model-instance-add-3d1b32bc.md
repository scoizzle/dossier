# Fact 3d1b32bc

Store id: cfc44db2-b239-4209-ae96-3129b18c6a21

## Text

```text
def pre_save(self, model_instance, add)
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
- posted_at: `2026-11-09T23:31:56.8232400+00:00`

## Data

```json
{
  "end_line": 2694,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2688,
  "symbol": "TimeField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2688,"selector":"L2688-L2694","symbol":"TimeField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2694,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2688,
    "symbol": "TimeField.pre_save"
  },
  "id": "cfc44db2-b239-4209-ae96-3129b18c6a21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8232400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2688,
        "selector": "L2688-L2694",
        "symbol": "TimeField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3549d256-0376-46ec-bade-1a74f3a3638b",
  "subject_name": "django/db/models/fields/__init__::TimeField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```
