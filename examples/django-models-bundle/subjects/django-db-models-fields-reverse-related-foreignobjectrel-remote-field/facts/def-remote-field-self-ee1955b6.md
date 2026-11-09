# Fact ee1955b6

Store id: 815a9bcc-8255-4053-ae08-a78ffbfddf1f

## Text

```text
def remote_field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.4275370+00:00`

## Data

```json
{
  "end_line": 75,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 73,
  "symbol": "ForeignObjectRel.remote_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":73,"selector":"L73-L75","symbol":"ForeignObjectRel.remote_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.remote_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 75,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 73,
    "symbol": "ForeignObjectRel.remote_field"
  },
  "id": "815a9bcc-8255-4053-ae08-a78ffbfddf1f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4275370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 73,
        "selector": "L73-L75",
        "symbol": "ForeignObjectRel.remote_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "20950a21-c8c1-4b23-92e2-83e4055a9e56",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.remote_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def remote_field(self)"
}
```
