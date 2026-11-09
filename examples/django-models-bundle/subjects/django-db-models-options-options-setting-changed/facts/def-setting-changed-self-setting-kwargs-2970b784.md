# Fact 2970b784

Store id: fcb2035a-d6a4-4a9c-b5f7-87d24929fd50

## Text

```text
def setting_changed(self, *, setting, **kwargs)
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
- posted_at: `2026-11-09T23:32:03.9547020+00:00`

## Data

```json
{
  "end_line": 451,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 449,
  "symbol": "Options.setting_changed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":449,"selector":"L449-L451","symbol":"Options.setting_changed"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.setting_changed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 451,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 449,
    "symbol": "Options.setting_changed"
  },
  "id": "fcb2035a-d6a4-4a9c-b5f7-87d24929fd50",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9547020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 449,
        "selector": "L449-L451",
        "symbol": "Options.setting_changed"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "5caa996a-963e-459f-9838-b88c3e2633a5",
  "subject_name": "django/db/models/options::Options.setting_changed",
  "tags": [
    "entity:method"
  ],
  "text": "def setting_changed(self, *, setting, **kwargs)"
}
```
