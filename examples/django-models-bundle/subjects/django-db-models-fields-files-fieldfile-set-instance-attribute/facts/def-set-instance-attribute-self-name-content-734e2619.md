# Fact 734e2619

Store id: ba47b2c3-3947-482b-a448-92374393492a

## Text

```text
def _set_instance_attribute(self, name, content)
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
- posted_at: `2026-11-09T22:39:43.2060720+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 96,
  "symbol": "FieldFile._set_instance_attribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L97","symbol":"FieldFile._set_instance_attribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._set_instance_attribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 96,
    "symbol": "FieldFile._set_instance_attribute"
  },
  "id": "ba47b2c3-3947-482b-a448-92374393492a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2060720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L97",
        "symbol": "FieldFile._set_instance_attribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "04727deb-a9da-403d-a8d8-8a6763866e94",
  "subject_name": "django/db/models/fields/files::FieldFile._set_instance_attribute",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_instance_attribute(self, name, content)"
}
```
