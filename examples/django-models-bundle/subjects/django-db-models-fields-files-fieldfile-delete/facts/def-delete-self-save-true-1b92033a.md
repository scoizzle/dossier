# Fact 1b92033a

Store id: 229af3c3-6d88-49c8-9b3f-97d6dc8051d8

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
- posted_at: `2026-11-09T22:39:43.2104590+00:00`

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
  "id": "229af3c3-6d88-49c8-9b3f-97d6dc8051d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2104590+00:00"
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
  "subject_id": "c9b66d94-1053-4557-9451-ba214ed88979",
  "subject_name": "django/db/models/fields/files::FieldFile.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, save=True)"
}
```
