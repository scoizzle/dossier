# Fact 3c70840f

Store id: d39c549f-8aa7-4384-8791-c01a08fdf658

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:31:56.7442180+00:00`

## Data

```json
{
  "end_line": 2359,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2349,
  "symbol": "GenericIPAddressField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2349,"selector":"L2349-L2359","symbol":"GenericIPAddressField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2359,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2349,
    "symbol": "GenericIPAddressField.to_python"
  },
  "id": "d39c549f-8aa7-4384-8791-c01a08fdf658",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7442180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2349,
        "selector": "L2349-L2359",
        "symbol": "GenericIPAddressField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1218952b-a12a-4107-bb4d-f634b925bb3d",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
