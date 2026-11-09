# Fact 6804fc89

Store id: 4cf6f6c8-32c4-4073-844e-2cb3b139b8e2

## Text

```text
def __init__(self, name, value)
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
- posted_at: `2026-11-09T23:31:57.1039340+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "method",
  "parent": "AttributeSetter",
  "start_line": 19,
  "symbol": "AttributeSetter.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L20","symbol":"AttributeSetter.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::AttributeSetter.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "method",
    "parent": "AttributeSetter",
    "start_line": 19,
    "symbol": "AttributeSetter.__init__"
  },
  "id": "4cf6f6c8-32c4-4073-844e-2cb3b139b8e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1039340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L20",
        "symbol": "AttributeSetter.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "285507ff-60aa-4645-99dd-1c71054c4bf2",
  "subject_name": "django/db/models/fields/composite::AttributeSetter.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, name, value)"
}
```
