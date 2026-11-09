# Fact e7e594dc

Store id: 3a7e1829-fc7a-47df-815c-ff1547d36d4f

## Text

```text
class FieldFile(File, AltersData)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.1687090+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 19,
  "symbol": "FieldFile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L156","symbol":"FieldFile"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 19,
    "symbol": "FieldFile"
  },
  "id": "3a7e1829-fc7a-47df-815c-ff1547d36d4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1687090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L156",
        "symbol": "FieldFile"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "d8c7c889-a81b-4129-8771-2ad2bc1635eb",
  "subject_name": "django/db/models/fields/files::FieldFile",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldFile(File, AltersData)"
}
```
