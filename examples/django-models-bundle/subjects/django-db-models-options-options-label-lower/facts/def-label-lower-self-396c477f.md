# Fact 396c477f

Store id: 622e3864-8a76-4ec2-99e6-b20911903c04

## Text

```text
def label_lower(self)
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
- posted_at: `2026-11-09T23:32:03.8963910+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 176,
  "symbol": "Options.label_lower"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"selector":"L176-L178","symbol":"Options.label_lower"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.label_lower](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 176,
    "symbol": "Options.label_lower"
  },
  "id": "622e3864-8a76-4ec2-99e6-b20911903c04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8963910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 176,
        "selector": "L176-L178",
        "symbol": "Options.label_lower"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "c3fd9ac7-ff56-4026-8886-342f118b15ff",
  "subject_name": "django/db/models/options::Options.label_lower",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label_lower(self)"
}
```
