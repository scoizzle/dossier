# Fact 7cab34ad

Store id: 3bdf4fe4-e6a8-4889-b958-c8536585ccee

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
- posted_at: `2026-11-09T22:39:43.1941300+00:00`

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
  "id": "3bdf4fe4-e6a8-4889-b958-c8536585ccee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1941300+00:00"
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
  "subject_id": "02c02a08-4c05-4a84-bb82-d403943240f0",
  "subject_name": "django/db/models/fields/files::FieldFile._get_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_file(self)"
}
```
