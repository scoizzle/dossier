# Fact baae8fa3

Store id: 72213a70-1556-4aef-83f6-5a3711c35048

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
- posted_at: `2026-11-09T23:31:56.8024160+00:00`

## Data

```json
{
  "end_line": 2571,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2568,
  "symbol": "TextField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2568,"selector":"L2568-L2571","symbol":"TextField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2571,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2568,
    "symbol": "TextField.to_python"
  },
  "id": "72213a70-1556-4aef-83f6-5a3711c35048",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8024160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2568,
        "selector": "L2568-L2571",
        "symbol": "TextField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6b956aa9-cccd-4805-b18e-37ad2ea3909c",
  "subject_name": "django/db/models/fields/__init__::TextField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
