# Fact 2970b784

Store id: 6fa6c001-0db3-4cf7-939b-194e63522040

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
- posted_at: `2026-11-09T23:44:55.5106350+00:00`

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
  "id": "6fa6c001-0db3-4cf7-939b-194e63522040",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5106350+00:00"
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
  "subject_id": "09cca59e-fa8b-4b38-af0d-b659475d8a3d",
  "subject_name": "django/db/models/options::Options.setting_changed",
  "tags": [
    "entity:method"
  ],
  "text": "def setting_changed(self, *, setting, **kwargs)"
}
```
