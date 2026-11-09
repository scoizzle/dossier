# Fact 7cab34ad

Store id: c39c5ce9-eec6-4360-b767-c3138e44d396

## Text

```text
def _get_file(self)
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
- posted_at: `2026-11-09T23:44:50.6202220+00:00`

## Data

```json
{
  "end_line": 54,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 50,
  "symbol": "FieldFile._get_file"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":50,"selector":"L50-L54","symbol":"FieldFile._get_file"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._get_file](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 54,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 50,
    "symbol": "FieldFile._get_file"
  },
  "id": "c39c5ce9-eec6-4360-b767-c3138e44d396",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6202220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 50,
        "selector": "L50-L54",
        "symbol": "FieldFile._get_file"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "46a62e00-2f6c-4867-bcf3-c3ef62cec3c1",
  "subject_name": "django/db/models/fields/files::FieldFile._get_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_file(self)"
}
```
