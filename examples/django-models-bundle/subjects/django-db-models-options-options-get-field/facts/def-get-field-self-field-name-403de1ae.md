# Fact 403de1ae

Store id: 4d11f475-f135-43f8-a8e7-f541c44fb7b1

## Text

```text
def get_field(self, field_name)
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
- posted_at: `2026-11-09T23:32:04.0011250+00:00`

## Data

```json
{
  "end_line": 695,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 670,
  "symbol": "Options.get_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":670,"selector":"L670-L695","symbol":"Options.get_field"}`

## Items

```json
[
  {
    "text": "Return a field instance given the name of a forward or reverse field.",
    "locator": {
      "line": 671
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 695,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 670,
    "symbol": "Options.get_field"
  },
  "id": "4d11f475-f135-43f8-a8e7-f541c44fb7b1",
  "items": [
    {
      "locator": {
        "line": 671
      },
      "text": "Return a field instance given the name of a forward or reverse field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0011250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 670,
        "selector": "L670-L695",
        "symbol": "Options.get_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "986020ab-4173-4d49-88e2-1fb5dd1fefc2",
  "subject_name": "django/db/models/options::Options.get_field",
  "tags": [
    "entity:method"
  ],
  "text": "def get_field(self, field_name)"
}
```
