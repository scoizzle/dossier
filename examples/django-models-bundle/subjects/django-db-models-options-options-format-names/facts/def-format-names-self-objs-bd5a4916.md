# Fact bd5a4916

Store id: b31d12e3-7c6a-41c8-8dbc-47a0084cdf82

## Text

```text
def _format_names(self, objs)
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
- posted_at: `2026-11-09T23:32:03.9063500+00:00`

## Data

```json
{
  "end_line": 259,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 251,
  "symbol": "Options._format_names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":251,"selector":"L251-L259","symbol":"Options._format_names"}`

## Items

```json
[
  {
    "text": "App label/class name interpolation for object names.",
    "locator": {
      "line": 252
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._format_names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 259,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 251,
    "symbol": "Options._format_names"
  },
  "id": "b31d12e3-7c6a-41c8-8dbc-47a0084cdf82",
  "items": [
    {
      "locator": {
        "line": 252
      },
      "text": "App label/class name interpolation for object names."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9063500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 251,
        "selector": "L251-L259",
        "symbol": "Options._format_names"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "347c1577-5603-443e-9502-e25a0b0da15c",
  "subject_name": "django/db/models/options::Options._format_names",
  "tags": [
    "entity:method"
  ],
  "text": "def _format_names(self, objs)"
}
```
