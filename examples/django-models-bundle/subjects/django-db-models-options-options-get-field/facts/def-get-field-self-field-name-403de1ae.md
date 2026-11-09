# Fact 403de1ae

Store id: 7e707460-9ceb-4aad-9be1-b76fe7fccce7

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
- posted_at: `2026-11-09T23:44:55.5515140+00:00`

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
  "id": "7e707460-9ceb-4aad-9be1-b76fe7fccce7",
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
    "posted_at": "2026-11-09T23:44:55.5515140+00:00"
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
  "subject_id": "974cf772-1b18-4319-b348-1320dcab2907",
  "subject_name": "django/db/models/options::Options.get_field",
  "tags": [
    "entity:method"
  ],
  "text": "def get_field(self, field_name)"
}
```
