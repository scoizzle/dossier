# Fact 34473866

Store id: d1711f26-3fb9-487e-9d71-a67a545e4103

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:31:57.3747070+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 141,
  "symbol": "FieldFile.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L152","symbol":"FieldFile.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 141,
    "symbol": "FieldFile.__getstate__"
  },
  "id": "d1711f26-3fb9-487e-9d71-a67a545e4103",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3747070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L152",
        "symbol": "FieldFile.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "2e81ab47-3a27-4c3b-bc67-030798687748",
  "subject_name": "django/db/models/fields/files::FieldFile.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
