# Fact 5c5ca401

Store id: dd96723f-6b97-46ca-9981-4493bffbd350

## Text

```text
def non_db_attrs(self)
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
- posted_at: `2026-11-09T23:44:51.5159910+00:00`

## Data

```json
{
  "end_line": 610,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 604,
  "symbol": "ForeignObject.non_db_attrs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":604,"selector":"L604-L610","symbol":"ForeignObject.non_db_attrs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.non_db_attrs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 610,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 604,
    "symbol": "ForeignObject.non_db_attrs"
  },
  "id": "dd96723f-6b97-46ca-9981-4493bffbd350",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5159910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 604,
        "selector": "L604-L610",
        "symbol": "ForeignObject.non_db_attrs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "850c9348-ba4c-4919-b2cc-f80b6089eac9",
  "subject_name": "django/db/models/fields/related::ForeignObject.non_db_attrs",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def non_db_attrs(self)"
}
```
