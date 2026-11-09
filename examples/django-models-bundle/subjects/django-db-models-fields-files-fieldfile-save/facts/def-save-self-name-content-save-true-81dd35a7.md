# Fact 81dd35a7

Store id: c7d9fc79-7291-4f9e-9090-3186d2dc902a

## Text

```text
def save(self, name, content, save=True)
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
- posted_at: `2026-11-09T23:31:57.3670560+00:00`

## Data

```json
{
  "end_line": 107,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 99,
  "symbol": "FieldFile.save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L107","symbol":"FieldFile.save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 107,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 99,
    "symbol": "FieldFile.save"
  },
  "id": "c7d9fc79-7291-4f9e-9090-3186d2dc902a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3670560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L107",
        "symbol": "FieldFile.save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "fd2c501d-f9dd-4360-95b5-e2a1d700e319",
  "subject_name": "django/db/models/fields/files::FieldFile.save",
  "tags": [
    "entity:method"
  ],
  "text": "def save(self, name, content, save=True)"
}
```
