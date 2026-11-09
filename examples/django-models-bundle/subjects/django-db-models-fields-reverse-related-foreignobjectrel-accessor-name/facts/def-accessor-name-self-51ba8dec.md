# Fact 51ba8dec

Store id: cc390896-454c-4ded-85e4-73d63b5be097

## Text

```text
def accessor_name(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.4909240+00:00`

## Data

```json
{
  "end_line": 212,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 210,
  "symbol": "ForeignObjectRel.accessor_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":210,"selector":"L210-L212","symbol":"ForeignObjectRel.accessor_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 212,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 210,
    "symbol": "ForeignObjectRel.accessor_name"
  },
  "id": "cc390896-454c-4ded-85e4-73d63b5be097",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4909240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 210,
        "selector": "L210-L212",
        "symbol": "ForeignObjectRel.accessor_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "5fc1eb8a-aa5c-402e-84a6-af6b46a92b8e",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def accessor_name(self)"
}
```
