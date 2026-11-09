# Fact 1b92033a

Store id: dd177be9-a080-42b0-8da0-a790fffb1f3e

## Text

```text
def delete(self, save=True)
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
- posted_at: `2026-11-09T23:31:57.3689340+00:00`

## Data

```json
{
  "end_line": 127,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 111,
  "symbol": "FieldFile.delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":111,"selector":"L111-L127","symbol":"FieldFile.delete"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 127,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 111,
    "symbol": "FieldFile.delete"
  },
  "id": "dd177be9-a080-42b0-8da0-a790fffb1f3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3689340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 111,
        "selector": "L111-L127",
        "symbol": "FieldFile.delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "c6a85c3a-d1ba-4e80-ae8e-09ba132b8902",
  "subject_name": "django/db/models/fields/files::FieldFile.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, save=True)"
}
```
