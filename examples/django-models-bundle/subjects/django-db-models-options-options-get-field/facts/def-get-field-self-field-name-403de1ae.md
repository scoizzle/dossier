# Fact 403de1ae

Store id: ce5a55ff-74f6-41c0-8bd1-a3765257ded3

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
- posted_at: `2026-11-09T22:39:48.8682070+00:00`

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
  "id": "ce5a55ff-74f6-41c0-8bd1-a3765257ded3",
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
    "posted_at": "2026-11-09T22:39:48.8682070+00:00"
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
  "subject_id": "52d262c7-48cb-421b-884f-f5b9fa966a1e",
  "subject_name": "django/db/models/options::Options.get_field",
  "tags": [
    "entity:method"
  ],
  "text": "def get_field(self, field_name)"
}
```
