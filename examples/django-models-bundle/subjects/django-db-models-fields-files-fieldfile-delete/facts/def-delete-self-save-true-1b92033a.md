# Fact 1b92033a

Store id: d9b280ba-e1eb-4c10-aa35-332222e1b7f8

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
- posted_at: `2026-11-09T23:44:50.6346820+00:00`

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
  "id": "d9b280ba-e1eb-4c10-aa35-332222e1b7f8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6346820+00:00"
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
  "subject_id": "d3112a87-294e-4989-88a5-4c1aa1a00159",
  "subject_name": "django/db/models/fields/files::FieldFile.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, save=True)"
}
```
